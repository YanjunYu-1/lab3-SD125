using lab3.Models;

namespace lab3.Data.BLL
{
    public class PassBLL
    {
        Irepository<Pass> repo;
        public PassBLL(Irepository<Pass> repository)
        {
            repo = repository;
        }

        public void CreatePass(Pass pass)
        {
            if (pass.Purchaser.Length >= 3 && pass.Purchaser.Length <= 20)
            {
                repo.Create(pass);
            }
            else
            {
                throw new Exception("Argument is not between 3 and 20 characters long");
            }

            //repo.Save();
        }
    }
}
