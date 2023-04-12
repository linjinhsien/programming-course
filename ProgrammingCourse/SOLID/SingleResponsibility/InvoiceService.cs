﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.SingleResponsibility
{
    internal class InvoiceService
    {
        private MailService mailService = new MailService();

        public record InvoiceItem(int id, string product, double price);
        public record Invoice(int id, string customer, string email, List<InvoiceItem> items);
        
        public void SaveInvoice(Invoice invoice)
        {
            // save invoice to db
            Console.WriteLine("Saving invoice");
        }

        public Invoice FindInoviceById(int id)
        {
            // finding in db
            return new Invoice(1, "John Smith", "john@smith.com", new List<InvoiceItem> {
                new InvoiceItem(1, "How to learn programming - EBOOK", 12.34)
            });
        }

        public void SendInvoiceByEmail(Invoice invoice)
        {
            string subject = GetInvoiceSubject(invoice);
            string body = GetInvoiceBody(invoice);

            mailService.SendMail("invoice@company.com", invoice.email, subject, body);
        }

        private string GetInvoiceBody(Invoice invoice)
        {
            return $"{invoice.customer} - {invoice.id}";
        }

        private string GetInvoiceSubject(Invoice invoice)
        {
            return $"invoice content {invoice.items.Count}";
        }
    }
}
