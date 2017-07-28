using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BangazonAPI.Models
{
   //SUMMARY
    /*This class is authored by Azim. 
      Order Class identifies the properties for the entries to the Order Tabel in database*/
  public class Order
  {
    /*This is the primary key for an entry on the Order table. It is generated by the database and doesn't
    need to be submitted by the user*/
    [Key]
    public int OrderId { get; set; }

    /*This property will be auto-generated by the database when it creates the order entry
    and doesn't need to be filled in by the user.*/
    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateCreated { get; set; }

    [Required]
    public int CustomerId { get; set; }
    //Customer type was initialized because it is a foreign key in this table
    public Customer Customer { get; set; }

    // ? means that the variable can be null
    public int? PaymentTypeId { get; set; } 

    //Payment type was initialized because it is a foreign key in this table
    public PaymentType PaymentType { get; set; }

    //The following is collection represent tables in which orderId is a Foreign Key
    public ICollection<OrderProduct> OrderProducts;
  }
}