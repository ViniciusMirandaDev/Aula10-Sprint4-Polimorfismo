namespace Aula10_Sprint4_Polimorfismo
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("o personagem está pulando normalmente");
        }

        public virtual void Correr(){
            System.Console.WriteLine("O personagem está correndo normalmente");
        }
        public virtual void Cair(){
            System.Console.WriteLine("O personagem está caindo normalmente");
        }

    }
}