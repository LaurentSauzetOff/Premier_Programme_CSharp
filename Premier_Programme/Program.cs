﻿namespace Premier_Programme
{
    class Program
    {

        static void AfficherInfosPersonne(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans.");
            Console.WriteLine("Bientôt vous aurez " + (age + 1) + " ans.");

            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");


            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeurr.");
            }
            else if (age > 18)
            {
                Console.WriteLine("Vous êtes majeur.");

                if (age >= 60)
                {
                    Console.WriteLine("Vous êtes un jeune senior.");
                }
            }
            else
            {
                Console.WriteLine("Vous êtes mineur.");

                if (age < 10)
                {
                    Console.WriteLine("Vous êtes un enfant");
                }
            }
        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";

            while (nom == "")
            {
                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ?");
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

        static int DemanderAge(string nom)
        {
            int ageNum = 0;

            while (ageNum <= 0)
            {
                Console.WriteLine(nom + ", quel est votre age ?");
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

            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);

            int ageNum1 = DemanderAge(nom1);
            int ageNum2 = DemanderAge(nom2);

            AfficherInfosPersonne(nom1, ageNum1);
            AfficherInfosPersonne(nom2, ageNum2);

        }

    }
}