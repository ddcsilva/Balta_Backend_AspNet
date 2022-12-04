using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Telas.TelasTag
{
    public static class TelaDeleteTag
    {
        public static void Carregar()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-------------");
            Console.Write("Qual o id da Tag que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            TelaMenuTag.Carregar();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}