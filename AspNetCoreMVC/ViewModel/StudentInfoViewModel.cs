using AspNetCoreMVC.Models;

namespace AspNetCoreMVC.ViewModel
{
    public class StudentInfoViewModel
    {
        public string Title { get; set; }
        public Student Student { get; set; }
        public Address Address { get; set; }
    }
}
