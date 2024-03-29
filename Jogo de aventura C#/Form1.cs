using Jogo_de_aventura_C_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_aventura_C_
{
    public partial class Form1 : Form
    {
        private Player Jogador;

        private Inimigos Morcego;
        private Inimigos Fantasma;
        private Inimigos Zombie;

        private Game Jogo;
        private Point ProximaLocalização;

        private List<PictureBox> ListaDeMonstros;
        private List<Objetos> ListaDeObjetosMonstros;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            Morcego = new Inimigos(Bat);
            Fantasma = new Inimigos(Ghost);
            Zombie = new Inimigos(Ghoul);

            ListaDeMonstros = new List<PictureBox>() { Bat, Ghoul, Ghost };
            ListaDeObjetosMonstros = new List<Objetos>() { Morcego, Fantasma, Zombie };
            Jogo = new Game(ListaDeMonstros);

            PassarFase();
        }
        private void PassarFase()
        {
            VerificarConteudoDaFase();

            Player.Location = new Point(485, 142);
            Jogo.PassarLevel(ListaDeMonstros);

            Jogador = new Player(Player);
            AtualizarVidas();
        }
        private void VerificarConteudoDaFase()
        {
            switch (Jogo.Level())
            {
                case 0:
                    ListaDeMonstros = new List<PictureBox>() { Player, Bat };
                    break;
                case 1:
                    ListaDeMonstros = new List<PictureBox>() { Player, Ghost };
                    break;
                case 2:
                    ListaDeMonstros = new List<PictureBox>() { Player, Ghoul };
                    break;
                case 3:
                    ListaDeMonstros = new List<PictureBox>() { Player, Bat, Ghost };
                    break;
                case 4:
                    ListaDeMonstros = new List<PictureBox>() { Player, Bat, Ghoul };
                    break;
                case 5:
                    ListaDeMonstros = new List<PictureBox>() { Player, Ghost, Ghoul };
                    break;
                case 6:
                    ListaDeMonstros = new List<PictureBox>() { Player, Bat, Ghoul, Ghost };
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }

        private void MUp_Click(object sender, EventArgs e)
        {
            if (Player.Location.Y > 62)
            {
                Player.Location = Jogador.Mover(Direção.Up);
            }

            MovimentaçãoDosMonstros();
        }
        private void MLeft_Click(object sender, EventArgs e)
        {
            if (Player.Location.X > 85)
            {
                Player.Location = Jogador.Mover(Direção.Left);
            }

            if (Player.Location.X == 85 && Player.Location.Y == 142)
            {
                PassarFase();
            }

            MovimentaçãoDosMonstros();
        }
        private void MRight_Click(object sender, EventArgs e)
        {
            if (Player.Location.X < 485)
            {
                Player.Location = Jogador.Mover(Direção.Right);
            }

            MovimentaçãoDosMonstros();
        }
        private void MDown_Click(object sender, EventArgs e)
        {
            if (Player.Location.Y < 222)
            {
                Player.Location = Jogador.Mover(Direção.Down);
            }

            MovimentaçãoDosMonstros();
        }

        private void AUp_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Up, Jogador);
            MovimentaçãoDosMonstros();
        }
        private void ALeft_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Left, Jogador);
            MovimentaçãoDosMonstros();
        }
        private void ARight_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Right, Jogador);
            MovimentaçãoDosMonstros();
        }
        private void ADown_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Down, Jogador);
            MovimentaçãoDosMonstros();
        }

        private void MovimentaçãoDosMonstros()
        {
            foreach (var item in ListaDeObjetosMonstros)
            {
                var DireçãoParaAndar = random.Next(4);
                MatarInimigoProximo((Direção)DireçãoParaAndar, item);
                switch (DireçãoParaAndar)
                {
                    case 0:
                        if (item.SuaPictureBox.Location.Y > 62)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                    case 1:
                        if (item.SuaPictureBox.Location.Y < 222)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                    case 2:
                        if (item.SuaPictureBox.Location.X > 85)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                    case 3:
                        if (item.SuaPictureBox.Location.X < 485)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                }
                AtualizarVidas();
            }
        }
        private void MatarInimigoProximo(Direção direção, Objetos atacante)
        {
            ProximaLocalização = atacante.VerificarRange(direção);

            VerificarSeTemInimigoProximo(atacante);
        }
        private void VerificarSeTemInimigoProximo(Objetos atacante)
        {
            foreach (var item in ListaDeObjetosMonstros)
            {
                if (ProximaLocalização == item.SuaPictureBox.Location)
                {
                    atacante.Atacar(item);
                }
            }
            if (ProximaLocalização == Jogador.SuaPictureBox.Location)
            {
                atacante.Atacar(Jogador);
                GameOver();
            }
        }

        private void AtualizarVidas()
        {
            PlayerLife.Text = Jogador.Vidas.ToString();
            BatLife.Text = Morcego.Vidas.ToString();
            GhostLife.Text = Fantasma.Vidas.ToString();
            GhoulLife.Text = Zombie.Vidas.ToString();
        }
        private void GameOver()
        {
            if (Jogador.Vidas < 1)
            {
                Application.Exit();
            }
        }
    }
}
