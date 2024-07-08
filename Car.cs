using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
		#region Attributes
		private int id;
		private string model;
		private double speed; 
		#endregion

		#region Properties
		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		public Car(int _id, string _model , double _speed)
		{
			id = _id;
			model = _model;	
			speed = _speed;
		}
		public Car(int _id,string _model ) :this( _id, _model , 180)
		{

		}
		public Car(int _id):this(_id , "Hundai") { }
		public Car() { }
        public override string ToString()
        {
            return $"ID : {id}\nModel : {model}\nSpeed : {speed}";
        }

    }
}
