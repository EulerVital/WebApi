using System.Data.Entity;

namespace WebApiProject1.Models
{
    public class WebApiProject1 : DbContext
    {
        public WebApiProject1() : base("name=WebApiProject1")
        {
        }
    }
}