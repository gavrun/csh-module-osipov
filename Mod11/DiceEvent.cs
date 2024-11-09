using System;

namespace ClasswithEvent
{
    class KubEventArgs : EventArgs
    {
        public int Count { get; set; }
        public KubEventArgs(int Count)
        {
            this.Count = Count;
        }
    }

    public delegate void EventHandlerrr();
    public delegate void EventHandlerr(int k);

    class Dice
    {

        Random r;
        public event EventHandler KubPlay;
        public event EventHandlerrr KubMax;
        public event EventHandlerr KubPlay2;

        //В конструкторе класса объявляем переменную r, генерируемую встроеным объектом Random
        public Dice()
        {
            r = new Random();
        }
        //Создаем метод, в котором будет вызываться событие.
        public void random()
        {
            int res = r.Next(6) + 1;
            KubEventArgs kubInPlay = new KubEventArgs (res); //Случайное число от 1 до 6.

            KubPlay2(res);

            if (KubPlay != null)
                KubPlay(this, kubInPlay);

            if (res == 6)
            {
                KubMax();
            }
        }
    }

    class Pit
    {
        public Pit(Dice kub)
        {
            kub.KubPlay += kub_KubPlay;
            kub.KubMax += kub_KubMax;
            kub.KubPlay2 += Kub_KubPlay2;
        }

        void Kub_KubPlay2(int k)
        {
            ShowKub(k);
        }

        void kub_KubMax()
        {
            ShowKub(); 
        }

        void kub_KubPlay(object sender, EventArgs e)
        {
            if (e is KubEventArgs)
            {
                KubEventArgs kubEventArgs = e as KubEventArgs;
                ShowKub(kubEventArgs.Count);
            }
        }

        public void ShowKub(int p)
        {
            Console.WriteLine("Смотрите! Выпало количество очков {0} ", p);
        }

        public void ShowKub()
        {
            Console.WriteLine("СМОТРИТЕ! Выпало максимальное количество очков 6");
        }


        class Gamer
        {
            string Name;
            Dice seans;

            public Gamer(string name, Dice seans)
            {
                Name = name;
                this.seans = seans;
                seans.KubPlay += seans_KubPlay;
            }

            public void SeansGame()
            {
                seans.random();
            }

            private void seans_KubPlay(object sender, EventArgs e)
            {
                if (e is KubEventArgs)
                {
                    KubEventArgs kubEventArgs = e as KubEventArgs;
                    ShowKubG(kubEventArgs.Count);
                }
            }

            private void ShowKubG(int p)
            {
                Console.WriteLine("Игроку {0} выпало количество очков {1}", Name, p);

            }
            
            public  override string ToString()
            {
                return Name;
            }
        }


        class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main(string[] args)
            {

                Dice brosok = new Dice();

                Gamer g1 = new Gamer("Niko", brosok);
                Pit p1 = new Pit(brosok);
              
                for (int i = 1; i <= 10; i++) 
                    g1.SeansGame();
            }
        }
    }
}

