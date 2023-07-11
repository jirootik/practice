using Database.DatabaseElement;
using Database.BaseContext;
using Microsoft.EntityFrameworkCore;


namespace DiascanPraktika.DatabaseData
{

    // Класс для заполнения базы данных тестовыми данными
    class DbInitializer
    {
        // Класс запоминает базу данных 
        private readonly Context _db;


        public DbInitializer(Context db)
        {
            _db = db;
        }

        public void Initialize()
        {
            _db.Database.Migrate();

            InitializeCars();
        }

        private const int __CarCount = 5;

        private Car[] _Cars;
        private void InitializeCars()
        {
            _Cars = new Car[__CarCount];
            Car Andrey = new Car("Honda", 80000.00);
            _Cars[Andrey.Id] = Andrey;

            this._db.Cars.AddRange(_Cars);
            this._db.SaveChanges();
        }
    }
}
