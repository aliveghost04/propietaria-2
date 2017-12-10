﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class products
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public products()
    {
        this.warehouse_products = new HashSet<warehouse_products>();
    }

    public int id { get; set; }
    public string name { get; set; }
    public string details { get; set; }
    public string characteristics { get; set; }
    public decimal unit_price { get; set; }
    public byte available { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<warehouse_products> warehouse_products { get; set; }
}

public partial class sessions
{
    public int id { get; set; }
    public string session { get; set; }
    public byte status { get; set; }
}

public partial class users
{
    public int id { get; set; }
    public string name { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string address { get; set; }
    public string phone_number { get; set; }
    public System.DateTime register_date { get; set; }
    public string credit_card_number { get; set; }
    public Nullable<short> credit_card_expiration_year { get; set; }
    public Nullable<byte> credit_card_expiration_month { get; set; }
    public Nullable<short> credit_card_cvv { get; set; }
    public string type { get; set; }
    public byte status { get; set; }
}

public partial class warehouse
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public warehouse()
    {
        this.warehouse_products = new HashSet<warehouse_products>();
    }

    public int id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public Nullable<decimal> latitude { get; set; }
    public Nullable<decimal> longitude { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<warehouse_products> warehouse_products { get; set; }
}

public partial class warehouse_products
{
    public int id { get; set; }
    public int warehouse_id { get; set; }
    public int product_id { get; set; }
    public int quantity { get; set; }

    public virtual products products { get; set; }
    public virtual warehouse warehouse { get; set; }
}
