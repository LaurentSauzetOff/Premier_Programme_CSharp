namespace Premier_Programme
{
    class Program
    {
        static string DemanderNom()
        {
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est votre nom ?");
                nom = Console.ReadLine();
                nom = nom.Trim();

                try
                {
                    if (nom == "")
                    {
                        Console.WriteLine("Le nom ne peut pas être vide.");
                    }
                }
                catch
                {
                    Console.WriteLine("Le nom doit être une chaine de caractères.");
                }

            }
            return nom;
        }

        static int DemanderAge()
        {
            int ageNum = 0;

            while (ageNum <= 0)
            {
                Console.WriteLine("Quel est votre age ?");
                string ageStr = Console.ReadLine();

                try
                {
                    ageNum = int.Parse(ageStr);

                    if (ageNum <= 0)
                    {
                        Console.WriteLine("L'age doit être supérieur à 0.");
                    }
                }
                catch
                {
                    Console.WriteLine("L'age doit être un nombre.");
                }
            }
            return ageNum;
        }

        static void Main(string[] args)
        {

            string nom = DemanderNom();

            int ageNum = DemanderAge();

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + ageNum + " ans.");

            int ageProchain = ageNum + 1;
            Console.WriteLine("Bientôt vous aurez " + ageProchain + " ans.");

        }
    }
}