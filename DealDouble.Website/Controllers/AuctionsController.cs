using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DealDouble.Entities;
using DealDouble.Services;
namespace DealDouble.Website.Controllers
{
    public class AuctionsController : Controller
    {
        AuctionsService ObjAuctionServices = new AuctionsService();
        // GET: Auctions


        [HttpGet]
        public ActionResult Index()
        {
           var auction= ObjAuctionServices.GetAllAuction();
            return View(auction);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction ObjAuction)
        {
            ObjAuctionServices.SaveAuction(ObjAuction);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var auction = ObjAuctionServices.GetAuctionByID(ID);
            return View(auction);
        }

        [HttpPost]
        public ActionResult Edit(Auction ObjAuction)
        {
            ObjAuctionServices.UpdateAuction(ObjAuction);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var auction = ObjAuctionServices.GetAuctionByID(ID);
            return View(auction);
        }

        [HttpPost]
        public ActionResult Delete(Auction ObjAuction)
        {
            ObjAuctionServices.DeleteAuction(ObjAuction);
            return RedirectToAction("Index");
        }
    }
}