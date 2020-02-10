using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{

    class Customer{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }

    public Customer(int Id, string Name, bool Active) {
 //  you can always use the keyword this to indicate this property or method
 //  have to use this when names are same as defined above in constructor/paramaters
 // everything on left is property of "=" evertything on right is parameter
            this.Id = Id;
            this.Name = Name;
            this.Active = Active = true;
    }
        // Try this short cut type prop then hit [tab]x2 [tab] to next  [enter]


        //  create default constructor as follows
        public Customer() { }
        
    }
}
