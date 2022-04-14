using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PdfManager : IPdfService
    {
        private IPdfRepository _pdfRepository;
        public PdfManager()
        {
            _pdfRepository = new PdfRepository();
        }
        public async Task<Pdf> CreatePaper(Pdf pdf)
        {
            return await _pdfRepository.CreatePaper(pdf);
        }
    }
}
