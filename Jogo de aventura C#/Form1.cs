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

        private Armas Espada;
        private Armas MaçaDeCombate;
        private Armas Arco;
        private Armas PoçãoVermelha;
        private Armas PoçãoAzul;

        private Game Jogo;

        private List<PictureBox> ListaDeObjetos;
        private List<PictureBox> ImagensDoInventario;
        private List<Objetos> ListaDeMonstros;
        private List<Armas> ListaDeArmas;

        private int DistanciaDeAtaque;

        private Point ProximaLocalização;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            ComeçoDoJogo();
        }

        public void ComeçoDoJogo()
        {
            ListaDeObjetos = new List<PictureBox>() { Bat, Ghoul, Ghost, Sworld, PotionRed, BluePotion };
            ImagensDoInventario = new List<PictureBox>() { InSworld, InBow, InEspinhos, InPotionBlue, InPotionRed };

            Jogo = new Game(ListaDeObjetos);

            CriarObjetos();

            PassarFase();

            ListaDeMonstros = new List<Objetos>() { Morcego, Fantasma, Zombie };
            ListaDeArmas = new List<Armas>() { Espada, Arco, MaçaDeCombate, PoçãoVermelha, PoçãoAzul };
        }
        private void CriarObjetos()
        {
            Jogador = new Player(Player, 40);
            Morcego = new Inimigos(Bat, 40);
            Fantasma = new Inimigos(Ghost, 60);
            Zombie = new Inimigos(Ghoul, 80);
            Espada = new Armas(Sworld, InSworld, true);
            MaçaDeCombate = new Armas(Espinhos, InEspinhos, true);
            Arco = new Armas(Bow, InBow, true);
            PoçãoVermelha = new Armas(PotionRed, InPotionRed, false);
            PoçãoAzul = new Armas(BluePotion, InPotionBlue, false);
        }
        private void PassarFase()
        {
            VerificarConteudoDaFase();

            Player.Location = Jogador.VoltarAoPontoOriginal();
            Jogo.PassarLevel(ListaDeObjetos);

            VoltarVidasAoMaximo();
            AtualizarVidas();
        }
        private void VoltarVidasAoMaximo()
        {
            Morcego.VoltarVidaAoMaximo();
            Fantasma.VoltarVidaAoMaximo();
            Zombie.VoltarVidaAoMaximo();
        }
        private void VerificarConteudoDaFase()
        {
            switch (Jogo.Level())
            {
                case 0:
                    ListaDeObjetos = new List<PictureBox>() { Player, Bat, Sworld };
                    break;
                case 1:
                    ListaDeObjetos = new List<PictureBox>() { Player, Ghost, BluePotion };
                    break;
                case 2:
                    ListaDeObjetos = new List<PictureBox>() { Player, Ghoul, Bow };
                    break;
                case 3:
                    ListaDeObjetos = new List<PictureBox>() { Player, Bat, Ghost, PotionRed };
                    break;
                case 4:
                    ListaDeObjetos = new List<PictureBox>() { Player, Bat, Ghoul, BluePotion, Espinhos };
                    break;
                case 5:
                    ListaDeObjetos = new List<PictureBox>() { Player, Ghost, Ghoul, PotionRed };
                    break;
                case 6:
                    ListaDeObjetos = new List<PictureBox>() { Player, Bat, Ghoul, Ghost, PotionRed, BluePotion };
                    break;
                default:
                    TelaVencer.Visible = true;
                    buttonReiniciar.Visible = true;
                    break;
            }
        }
        private void AtualizarVidas()
        {
            PlayerLife.Text = Jogador.PegarValorDeVida().ToString();
            BatLife.Text = Morcego.PegarValorDeVida().ToString();
            GhostLife.Text = Fantasma.PegarValorDeVida().ToString();
            GhoulLife.Text = Zombie.PegarValorDeVida().ToString();
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            if (Player.Location.Y > 62)
            {
                Player.Location = Jogador.Mover(Direção.Up);
            }

            MovimentaçãoDosMonstros();

            VerificarSeTemItemProximo();
        }
        private void MoveLeft_Click(object sender, EventArgs e)
        {
            if (Player.Location.X > 85)
            {
                Player.Location = Jogador.Mover(Direção.Left);
            }

            MovimentaçãoDosMonstros();

            VerificarSeTemItemProximo();

            if (Player.Location.X == 85 && Player.Location.Y == 142)
            {
                PassarFase();
            }
        }
        private void MoveRight_Click(object sender, EventArgs e)
        {
            if (Player.Location.X < 485)
            {
                Player.Location = Jogador.Mover(Direção.Right);
            }

            MovimentaçãoDosMonstros();

            VerificarSeTemItemProximo();
        }
        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (Player.Location.Y < 222)
            {
                Player.Location = Jogador.Mover(Direção.Down);
            }

            MovimentaçãoDosMonstros();

            VerificarSeTemItemProximo();
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Up, Jogador);
            MovimentaçãoDosMonstros();
        }
        private void AttackLeft_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Left, Jogador);
            MovimentaçãoDosMonstros();
        }
        private void AttackRight_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Right, Jogador);
            MovimentaçãoDosMonstros();
        }
        private void AttackDown_Click(object sender, EventArgs e)
        {
            MatarInimigoProximo(Direção.Down, Jogador);
            MovimentaçãoDosMonstros();
        }

        private void MovimentaçãoDosMonstros()
        {
            foreach (var item in ListaDeMonstros)
            {
                var DireçãoParaAndar = random.Next(4);
                MatarInimigoProximo((Direção)DireçãoParaAndar, item);
                switch (DireçãoParaAndar)
                {
                    case 0:
                        if (item.SuaPictureBox.Location.Y > 22 + item.CasasQueAnda)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                    case 1:
                        if (item.SuaPictureBox.Location.Y < 182 - item.CasasQueAnda)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                    case 2:
                        if (item.SuaPictureBox.Location.X > 85 + item.CasasQueAnda)
                        {
                            item.SuaPictureBox.Location = item.Mover((Direção)DireçãoParaAndar);
                        }
                        break;
                    case 3:
                        if (item.SuaPictureBox.Location.X < 485 - item.CasasQueAnda)
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

            Objetos inimigo;

            if (atacante == Jogador)
            {
                foreach (var item in ListaDeMonstros)
                {
                    inimigo = item;

                    VerificarSeTemInimigoProximo(atacante, direção, inimigo);
                }
            }
            else
            {
                inimigo = Jogador;

                VerificarSeTemInimigoProximo(atacante, direção, inimigo);

                if (Jogador.PegarValorDeVida() < 1)
                {
                    TelaPerder.Visible = true;
                    buttonReiniciar.Visible = true;
                }
            }
        }
        private void VerificarSeTemInimigoProximo(Objetos atacante, Direção direção, Objetos inimigo)
        {
            int DistanciaX = atacante.SuaPictureBox.Location.X - inimigo.SuaPictureBox.Location.X;
            int DistanciaY = atacante.SuaPictureBox.Location.Y - inimigo.SuaPictureBox.Location.Y;

            if (direção == Direção.Up && DistanciaY <= DistanciaDeAtaque && DistanciaY >= 0 && DistanciaX <= 30 && DistanciaX >= -30)
            {
                atacante.Atacar(inimigo);
            }
            else if (direção == Direção.Down && DistanciaY >= -DistanciaDeAtaque && DistanciaY <= 0 && DistanciaX <= 30 && DistanciaX >= -30)
            {
                atacante.Atacar(inimigo);
            }
            else if (direção == Direção.Left && DistanciaX <= DistanciaDeAtaque && DistanciaX >= 0 && DistanciaY <= 30 && DistanciaY >= -30)
            {
                atacante.Atacar(inimigo);
            }
            else if (direção == Direção.Right && DistanciaX >= -DistanciaDeAtaque & DistanciaX <= 0 && DistanciaY <= 30 && DistanciaY >= -30)
            {
                atacante.Atacar(inimigo);
            }
        }    
        private void VerificarSeTemItemProximo()
        {
            foreach (var item in ListaDeArmas)
            {
                if (item.SuaPictureBox.Location == Jogador.SuaPictureBox.Location && item.SuaPictureBox.Visible)
                {
                    Jogador.PegarItem(item);
                }
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            buttonReiniciar.Visible = false;
            TelaPerder.Visible = false;
            TelaVencer.Visible = false;

            foreach (var item in ImagensDoInventario)
            {
                item.Visible = false;
            }

            Jogador = new Player(Player, 40);
            Jogo.VoltarLevelAZero();
            PassarFase();
        }

        private void InSworld_Click(object sender, EventArgs e)
        {
            Jogador.VerificarSeArmaCausaDano(Espada);
            Jogador.MudarDanoDaArma(2);
            DistanciaDeAtaque = 40;

            foreach (var item in ImagensDoInventario)
            {
                item.BorderStyle = BorderStyle.None;
            }
            InSworld.BorderStyle = BorderStyle.Fixed3D;
        }
        private void InEspinhos_Click(object sender, EventArgs e)
        {
            Jogador.VerificarSeArmaCausaDano(MaçaDeCombate);
            Jogador.MudarDanoDaArma(3);
            DistanciaDeAtaque = 60;

            foreach (var item in ImagensDoInventario)
            {
                item.BorderStyle = BorderStyle.None;
            }
            InEspinhos.BorderStyle = BorderStyle.Fixed3D;
        }
        private void InBow_Click(object sender, EventArgs e)
        {
            Jogador.VerificarSeArmaCausaDano(Arco);
            Jogador.MudarDanoDaArma(1);
            DistanciaDeAtaque = 80;

            foreach (var item in ImagensDoInventario)
            {
                item.BorderStyle = BorderStyle.None;
            }
            InBow.BorderStyle = BorderStyle.Fixed3D;
        }
        private void InPotionRed_Click(object sender, EventArgs e)
        {
            Jogador.VerificarSeArmaCausaDano(PoçãoVermelha);

            foreach (var item in ImagensDoInventario)
            {
                item.BorderStyle = BorderStyle.None;
            }

            Jogador.UsarPoção(10);

            InPotionRed.Visible = false;
            AtualizarVidas();
        }
        private void InPotionBlue_Click(object sender, EventArgs e)
        {
            Jogador.VerificarSeArmaCausaDano(PoçãoAzul);

            foreach (var item in ImagensDoInventario)
            {
                item.BorderStyle = BorderStyle.None;
            }

            Jogador.UsarPoção(5);

            InPotionBlue.Visible = false;
            AtualizarVidas();
        }
    }
}
