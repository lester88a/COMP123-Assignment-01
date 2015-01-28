using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Student Name: LI XU
 *Student ID: 300735072
 *Assignment 1
 *Due Date: Friday January 30th, 2015
 *Value:5% marks
 */
namespace Assignment1
{
    class Hero
    {
        //creats properties++++++++++++++++++++++++++++++++++++++++++++++++++++

        //creats private properties 
        private int strength;
        private int speed;
        private int health;

        //creats public properties 
        public string name;

        //Constructor methods++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero (string name)
        {
            this.name = name;//pass the this.name value to the name properties

            generateAbilities(); //call generateAbilities() method
        }

        // creats the private generateAbilities method
        private void generateAbilities()
        {
            //generates random numbers of strength, speed ,health between 1 to 100
            Random strength = new Random();
            this.strength = strength.Next(1, 100);

            Random speed = new Random();
            this.speed = speed.Next(1, 100);

            Random health = new Random();
            this.health = health.Next(1, 100);
        }

        //generates the public fight Method
        public void fight()
        {
            if (hitAttempt() == true) //If hitAttempt returns true, then it will call the hitDamage method
            {
                hitDamage();
            }
            show();
        }

        //cerat a private hitAttempt method
        private bool hitAttempt()
        {
            if (this.health >= 1 && this.health <= 20) //if the hero hits, the health is between 1-20
            {
                Console.WriteLine("Hero attempt to hit!");
                Console.WriteLine("The hit attempt score is {0}.", this.health);
                return true;
            }
            else
            {
                Console.WriteLine("Hero is not hit!");
                Console.WriteLine("generates the this.health false number is {0}.", this.health);
                return false;
            }
        }

        //cerat a private hitDamage method
        private int hitDamage()
        { 
            Random randomNumber=new Random();
            int damages = this.strength * randomNumber.Next(1, 6);// multiply the strength by a random number
            return damages;
            
        }

        //display hero's ability score
        public void show()
        {

            Console.WriteLine("The hero's damage score is {0}",this.hitDamage());
        }


    }
}
