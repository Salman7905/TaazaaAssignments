using System;
namespace PropertiesAssignment
{
    public class Laptop
    {
        private string _brand;
        private string _model;
    
    public string Brand
    {
        get
        {
            return _brand;
        }
        set
        {
          _brand=value;
        }
    }
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            _model=value;
        }
    }
 }
}
