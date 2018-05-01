//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using ProvalusAssetManagement.Models;
//using QRCoder;

//namespace ProvalusAssetManagement.Controllers

//{
//    public class QRReadersController : Controller
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();

//        // GET: QRReaders
//        public ActionResult Index()
//        {
//            return View(db.QRReaders.ToList());
//        }

//        // GET: QRReaders/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            QRReader qRReader = db.QRReaders.Find(id);
//            if (qRReader == null)
//            {
//                return HttpNotFound();
//            }
//            return View(qRReader);
//        }

//        // GET: QRReaders/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: QRReaders/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "QRID,QRCode")] QRReader qRReader)
//        {
//            if (ModelState.IsValid)
//            {
//                db.QRReaders.Add(qRReader);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(qRReader);
//        }

//        // GET: QRReaders/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            QRReader qRReader = db.QRReaders.Find(id);
//            if (qRReader == null)
//            {
//                return HttpNotFound();
//            }
//            return View(qRReader);
//        }

//        // POST: QRReaders/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "QRID,QRCode")] QRReader qRReader)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(qRReader).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(qRReader);
//        }

//        // GET: QRReaders/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            QRReader qRReader = db.QRReaders.Find(id);
//            if (qRReader == null)
//            {
//                return HttpNotFound();
//            }
//            return View(qRReader);
//        }

//        // POST: QRReaders/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            QRReader qRReader = db.QRReaders.Find(id);
//            db.QRReaders.Remove(qRReader);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }


//        public partial class _Default : System.Web.UI.Page
//        {
//            protected void Page_Load(object sender, EventArgs e)
//            {

//            }

//            protected void btnGenerate_Click(object sender, EventArgs e)
//            {
//                string Code = txtCode.Text;
//                QRCodeGenerator qrGenerator = new QRCodeGenerator();
//                QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(Code, QRCodeGenerator.ECCLevel.Q);

//                System.Web.UI.WebControls.Image imgQRCode = new System.Web.UI.WebControls.Image();
//                imgQRCode.Height = 150;
//                imgQRCode.Width = 150;

//                using (BitMap bitmap = qrCode.GetGraphic(20))
//                {
//                    using (MemoryStream ms = new MemoryStream())
//                    {
//                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
//                        byte[] byteImage = ms.ToArray();
//                        imgQRCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);

//                    }
//                    PHQRCode.Controls.Add(imgQRCode);




//                    //        }


//                    //    }
















//                }




//            }

    
    


