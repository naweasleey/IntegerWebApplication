using System.ComponentModel.DataAnnotations;

namespace IntegerWebApplication.Models
{
    public class Car
    {
        //[Key] //untuk menandakan kalo itu primary key
        //biasanya variabel yang ada 'id' nya otomatis jadi primary key
        public int IDRegistration { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Varian { get; set; }

    }
}

// cara membuat model otomatis dengan view dengan yang ada mvcnya
//nama controller harus sama dengan folder di view
