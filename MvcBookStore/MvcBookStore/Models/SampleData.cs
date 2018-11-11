using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBookStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BookStoreEntities>
    {
        protected override void Seed(BookStoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Biografia" },
                new Genre { Name = "Romans" },
                new Genre { Name = "Fantastyka" },
                new Genre { Name = "Thriller" },
                new Genre { Name = "Turystyka i podróże" },
            };

            var Authors = new List<Author>
            {
                new Author { Name = "Blake Mark" },
                new Author { Name = "Batchelor Bob" },
                new Author { Name = "Boniecki Adam" },
                new Author { Name = "Mróz Remigiusz" },
                new Author { Name = "Bałuk Kamil" },
                new Author { Name = "Buczkowski Waldemar" },

                new Author { Name = "Hoover Colleen" },
                new Author { Name = "Haner K. N." },
                new Author { Name = "Armentrout Jennifer L." },
                new Author { Name = "Michaels Corinne" },
                new Author { Name = "Lauren Christina"  },

                new Author { Name = "King Stephen" },
                new Author { Name = "Martin George R. R." },
                new Author { Name = "Kossakowska Maja Lidia" },
                new Author { Name = "Tolkien John Ronald Reuel" },

                new Author { Name = "Matyszczak Marta" },
                new Author { Name = "Świst Paulina" },
                new Author { Name = "Grzegorczyk Jan" },
                new Author { Name = "Coben Harlan" },
                new Author { Name = "Walker Wendy" },

                new Author { Name = "Biernat Marta" },
                new Author { Name = "Wójcik Tomasz" },
                new Author { Name = "Dylewski Adam" },
                new Author { Name = "Hryń-Kuśmierek Renata" },
                new Author { Name = "Pytel-Skiba Ewa" },
            };

            new List<Book>
            {
                new Book { Title = "Queen.Królewska historia", Genre = genres.Single(g => g.Name == "Biografia"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Blake Mark"),          BookArtUrl = "/Content/Images/Covers/biography/queen-krolewska-historia.jpg" },
                new Book { Title = "Stan Lee.Człowiek-Marvel", Genre = genres.Single(g => g.Name == "Biografia"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Batchelor Bob"),       BookArtUrl = "/Content/Images/Covers/biography/stan-lee-czlowiek-marvel.jpg" },
                new Book { Title = "Rozmowy o życiu",          Genre = genres.Single(g => g.Name == "Biografia"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Boniecki Adam"),       BookArtUrl = "/Content/Images/Covers/biography/boniecki-rozmowy-o-zyciu.jpg"},
                new Book { Title = "O pisaniu. Na chłodno",    Genre = genres.Single(g => g.Name == "Biografia"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Mróz Remigiusz"),      BookArtUrl = "/Content/Images/Covers/biography/o-pisaniu-na-chlodno.jpg" },
                new Book { Title = "Wodecki.Tak mi wyszło",    Genre = genres.Single(g => g.Name == "Biografia"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Bałuk Kamil"),         BookArtUrl = "/Content/Images/Covers/biography/wodecki-tak-mi-wyszlo.jpg" },
                new Book { Title = "IRA. Bo jest paru ludzi",  Genre = genres.Single(g => g.Name == "Biografia"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Buczkowski Waldemar"), BookArtUrl = "/Content/Images/Covers/biography/ira-bo-jest-paru-ludzi.jpg" },

                new Book { Title = "Wszystkie nasze obietnice", Genre = genres.Single(g => g.Name == "Romans"), Price = 35.99M,  Author = Authors.Single(a => a.Name == "Hoover Colleen"),          BookArtUrl = "/Content/Images/Covers/romance/wszystkie-nasze-obietnice.jpg" },
                new Book { Title = "Sponsor. Tom 1",            Genre = genres.Single(g => g.Name == "Romans"), Price = 19.99M,  Author = Authors.Single(a => a.Name == "Haner K. N."),             BookArtUrl = "/Content/Images/Covers/romance/sponsor-tom-1.jpg" },
                new Book { Title = "Lucyfer",                   Genre = genres.Single(g => g.Name == "Romans"), Price = 19.99M,  Author = Authors.Single(a => a.Name == "Armentrout Jennifer L."),  BookArtUrl = "/Content/Images/Covers/romance/lucyfer.jpg"},
                new Book { Title = "Powiedz, że zostaniesz",    Genre = genres.Single(g => g.Name == "Romans"), Price = 19.99M,  Author = Authors.Single(a => a.Name == "Michaels Corinne"),        BookArtUrl = "/Content/Images/Covers/romance/powiedz-ze-zostaniesz.jpg" },
                new Book { Title = "Dziki romans",              Genre = genres.Single(g => g.Name == "Romans"), Price = 35.99M,  Author = Authors.Single(a => a.Name == "Lauren Christina"),        BookArtUrl = "/Content/Images/Covers/romance/dziki-romans.jpg" },

                new Book { Title = "Oczy smoka",                             Genre = genres.Single(g => g.Name == "Fantastyka"), Price = 35.99M, Author = Authors.Single(a => a.Name == "King Stephen"),               BookArtUrl = "/Content/Images/Covers/fantasy/oczy-smoka.jpg" },
                new Book { Title = "Uniesienie",                             Genre = genres.Single(g => g.Name == "Fantastyka"), Price = 19.99M, Author = Authors.Single(a => a.Name == "King Stephen"),               BookArtUrl = "/Content/Images/Covers/fantasy/uniesienie.jpg" },
                new Book { Title = "Ogień i krew",                           Genre = genres.Single(g => g.Name == "Fantastyka"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Martin George R. R."),        BookArtUrl = "/Content/Images/Covers/fantasy/ogien-i-krew.jpg" },
                new Book { Title = "Bramy światłości. Tom 3",                Genre = genres.Single(g => g.Name == "Fantastyka"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Kossakowska Maja Lidia"),     BookArtUrl = "/Content/Images/Covers/fantasy/bramy-swiatlosci-tom-3.jpg" },
                new Book { Title = "Dzieci Hurina",                          Genre = genres.Single(g => g.Name == "Fantastyka"), Price = 19.99M, Author = Authors.Single(a => a.Name == "Tolkien John Ronald Reuel"), BookArtUrl = "/Content/Images/Covers/fantasy/dzieci-hurina.jpg" },
                new Book { Title = "Opowieści z Niebezpiecznego Królestwa ", Genre = genres.Single(g => g.Name == "Fantastyka"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Tolkien John Ronald Reuel"),  BookArtUrl = "/Content/Images/Covers/fantasy/opowiesci-z-niebezpiecznego-krolestwa.jpg" },

                new Book { Title = "Karuzela",                  Genre = genres.Single(g => g.Name == "Thriller"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Świst Paulina"),    BookArtUrl = "/Content/Images/Covers/thriller/karuzela.jpg" },
                new Book { Title = "Nigdy nie zapomnisz",       Genre = genres.Single(g => g.Name == "Thriller"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Coben Harlan"),     BookArtUrl = "/Content/Images/Covers/thriller/nigdy-nie-zapomnisz.jpg" },
                new Book { Title = "Puszczyk",                  Genre = genres.Single(g => g.Name == "Thriller"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Grzegorczyk Jan"),  BookArtUrl = "/Content/Images/Covers/thriller/puszczyk.jpg"},
                new Book { Title = "Śladami Emmy",              Genre = genres.Single(g => g.Name == "Thriller"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Walker Wendy"),     BookArtUrl = "/Content/Images/Covers/thriller/sladami-emmy.jpg" },
                new Book { Title = "Zło czai się na szczycie",  Genre = genres.Single(g => g.Name == "Thriller"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Matyszczak Marta"), BookArtUrl = "/Content/Images/Covers/thriller/zlo-czai-sie-na-szczycie.jpg" },

                new Book { Title = "Laponia. Wszystkie imiona śniegu  ", Genre = genres.Single(g => g.Name == "Turystyka i podróże"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Biernat Marta"),         BookArtUrl = "/Content/Images/Covers/travel/laponia.jpg" },
                new Book { Title = "Nasza Polska. Zamki i pałace",       Genre = genres.Single(g => g.Name == "Turystyka i podróże"), Price = 24.99M, Author = Authors.Single(a => a.Name == "Wójcik Tomasz"),         BookArtUrl = "/Content/Images/Covers/travel/nasza-polska-zamki-i-palace.jpg" },
                new Book { Title = "Izrael",                             Genre = genres.Single(g => g.Name == "Turystyka i podróże"), Price = 19.99M, Author = Authors.Single(a => a.Name == "Dylewski Adam"),         BookArtUrl = "/Content/Images/Covers/travel/izrael.jpg"},
                new Book { Title = "Rok Polski. Zwyczaje i Obrzędy",     Genre = genres.Single(g => g.Name == "Turystyka i podróże"), Price = 35.99M, Author = Authors.Single(a => a.Name == "Hryń-Kuśmierek Renata"), BookArtUrl = "/Content/Images/Covers/travel/rok-polski-zwyczaje-i-obrzedy.jpg" },
                new Book { Title = "Meksyk. Jukatan i Chiapas",          Genre = genres.Single(g => g.Name == "Turystyka i podróże"), Price = 19.99M, Author = Authors.Single(a => a.Name == "Pytel-Skiba Ewa"),       BookArtUrl = "/Content/Images/Covers/travel/meksyk.jpg" },
            }.ForEach(a => context.Books.Add(a));
        }
    }
}