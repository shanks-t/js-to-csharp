using System;
using System.Collections.Generic;

namespace EnemiesList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Enemies List!");
            Console.WriteLine("----------------");
            List<Enemy> enemies = GetEnemies();

            foreach (Enemy myEnemy in enemies)
            {
                if (myEnemy.IsReallyHated)
                {
                    Console.WriteLine($"{myEnemy.FirstName} {myEnemy.LastName} (Really, really dislike!)");
                }
                else
                {
                    Console.WriteLine($"{myEnemy.FirstName} {myEnemy.LastName}");
                }
            }
        }

        public static List<Enemy> GetEnemies()
        {
            List<Enemy> enemies = new List<Enemy> {
                new Enemy {
                    FirstName = "Joshua",
                    LastName = "Flowers",
                    Offenses = new List<string> {
                        "Being a jerk to me in elementary school",
                        "Not being nice to me in elementary school"
                    },
                    IsReallyHated = true
                },
                new Enemy {
                    FirstName = "Darth",
                    LastName = "Vader",
                    Offenses = new List<string> {
                        "Cut off Luke's hand",
                        "Murdered all those kids",
                        "Unkind management practices"
                    },
                    IsReallyHated = false
                },
                new Enemy {
                    FirstName = "Betty",
                    LastName = "Rudelady",
                    Offenses = new List<string> {
                        "Phone calls in the theater",
                        "Phone calls on the bus",
                        "Phone calls in line at the grocery store",
                        "Poor conversationalist"
                    },
                    IsReallyHated = true
                },
                new Enemy {
                    FirstName = "Leon",
                    LastName = "Peck",
                    Offenses = new List<string> {
                        "Keeps giving me a hotplate"
                    },
                    IsReallyHated = false
                }
            };

            return enemies;
        }
    }

    public class Enemy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsReallyHated { get; set; }
        public List<string> Offenses { get; set; }
    }
}
