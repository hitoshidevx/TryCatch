using System;
namespace Aula13TryCatch
{
    public class Error
    {
        private bool Access { get; set; }
        public void Authorize(){
            try
            {
                Console.WriteLine ("Escolha uma opção entre: True or false.");
                Access = Boolean.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine ("Houve um erro nos dados inseridos.");
            }
        }
            
        }
    }