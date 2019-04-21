namespace CityNote
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NoteContext : DbContext
    {
        // Контекст настроен для использования строки подключения "NoteContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "CityNote.NoteContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "NoteContext" 
        // в файле конфигурации приложения.
        public NoteContext()
            : base("name=NoteContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}