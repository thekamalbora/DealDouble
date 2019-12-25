using DealDouble.Data;
using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Services
{
    public class AuctionsService
    {
        DealDoubleContext context = new DealDoubleContext(); //Connection With Database
        public void SaveAuction(Auction ObjAuction)
        {
            context.Auctions.Add(ObjAuction); //Insert Data In Database
            context.SaveChanges(); //Save Data In Data Base
        }

        public List<Auction> GetAllAuction()
        {
            return context.Auctions.ToList();
        }

        public Auction GetAuctionByID(int AuctionID)
        {
            return context.Auctions.Find(AuctionID);//Find Id In DataBase
        }

        public void UpdateAuction(Auction ObjAuction)
        {
            context.Entry(ObjAuction).State = System.Data.Entity.EntityState.Modified;//update Data In Database
            context.SaveChanges(); //Save Data In Data Base
        }
        public void DeleteAuction(int ID)
        {
            Auction ObjAuction = context.Auctions.Find(ID);
            context.Auctions.Remove(ObjAuction);
            context.SaveChanges();
          ///*  context.Auctions.Remove(ObjAuction);*///delete Data In Database
          //  context.Entry(ObjAuction).State = System.Data.Entity.EntityState.Deleted;
          //  context.SaveChanges(); //Save Data In Data Base
       
        }

    }
}
