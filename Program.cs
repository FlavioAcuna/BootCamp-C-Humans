namespace human
{

    class Human
    {
        // Propiedades para el ser humano
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;
        // Añadir un constructor que toma un valor para establecer Nombre, y establecer el resto de los campos a los valores por defecto
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        // Añadir un constructor para asignar valores personalizados a todos los campos
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        // Método Build Attack
        public int Attack(Human target)
        {
            Human enemigo = target;
            int enemyhealth = enemigo.Health;
            if (enemigo == null)
            {
                Console.WriteLine("El ataque Fallo");
            }
            else
            {
                enemigo.Health -= Strength * 3;
            }
            return enemyhealth;
        }
    }


}