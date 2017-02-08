using System;
using System.Collections.ObjectModel;

namespace ListviewInsideOfScrollViewXF
{
	public class DataVm: BaseViewModel
	{
		protected ObservableCollection<Person> _dataItems;
		public ObservableCollection<Person> DataItems
		{
			get { return _dataItems; }
			set
			{
				if (_dataItems == value)
					return; _dataItems = value;
			}
		}

		public DataVm()
		{
			DataItems = new ObservableCollection<Person>();
			Person p1 = new Person();
			p1.Id = 1;
			p1.Name = "Osvaldo";
			p1.LastName = "Santiago";
			p1.Age = "25";
			p1.School = "ITS";
			p1.Degree = "Mexico";
			Person p2 = new Person();
			p2.Id = 2;
			p2.Name = "Ramon";
			p2.LastName = "Estrada";
			p2.Age = "23";
			p2.School = "UDG";
			p2.Degree = "Mexico";
			Person p3 = new Person();
			p3.Id = 3;
			p3.Name = "Heriberto";
			p3.LastName = "Marquez";
			p3.Age = "28";
			p3.School = "UNIVA";
			p3.Degree = "Mexico";

			Person p4 = new Person();
			p4.Id = 4;
			p4.Name = "Antonio";
			p4.LastName = "Lopez";
			p4.Age = "28";
			p4.School = "UNIVA";
			p4.Degree = "Mexico";

			Person p5 = new Person();
			p5.Id = 5;
			p5.Name = "Jesus";
			p5.LastName = "Romero";
			p5.Age = "28";
			p5.School = "UNIVA";
			p5.Degree = "Mexico";

			Person p6 = new Person();
			p6.Id = 3;
			p6.Name = "Francisco";
			p6.LastName = "Gonzalez";
			p6.Age = "28";
			p6.School = "UNIVA";
			p6.Degree = "Mexico";

			Person p7 = new Person();
			p7.Id = 3;
			p7.Name = "Carlos";
			p7.LastName = "Marquez";
			p7.Age = "28";
			p7.School = "UNIVA";
			p7.Degree = "Mexico";

			Person p8 = new Person();
			p8.Id = 8;
			p8.Name = "Eduardo";
			p8.LastName = "Ortiz";
			p8.Age = "28";
			p8.School = "UNIVA";
			p8.Degree = "Mexico";

			Person p9 = new Person();
			p9.Id = 3;
			p9.Name = "Horacio";
			p9.LastName = "Ortiz";
			p9.Age = "28";
			p9.School = "UNIVA";
			p9.Degree = "Mexico";

			Person p10 = new Person();
			p10.Id = 10;
			p10.Name = "Salvador";
			p10.LastName = "Marquez";
			p10.Age = "28";
			p10.School = "UNIVA";
			p10.Degree = "Mexico";

			Person p11 = new Person();
			p11.Id = 11;
			p11.Name = "Nery";
			p11.LastName = "Gallardo";
			p11.Age = "28";
			p11.School = "UNIVA";
			p11.Degree = "Mexico";

			DataItems.Add(p1);
			DataItems.Add(p2);
			DataItems.Add(p3);
			DataItems.Add(p4);
			DataItems.Add(p5);
			DataItems.Add(p6);
			DataItems.Add(p7);
			DataItems.Add(p8);
			DataItems.Add(p9);
			DataItems.Add(p10);
			DataItems.Add(p11);

			for (int i = 1; i < 10; i++)
			{
				Person per = new Person();
				per.Id = 11+i;
				per.Name = "Juan";
				per.LastName = "Perez";
				per.Age = "28";
				per.School = "UNIVA";
				per.Degree = "Mexico";
				DataItems.Add(per);
			}
		}

	}
}
