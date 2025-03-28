using System;
using NUnit.Framework;
using PSU.Models;
using Reqnroll;

namespace BehaviorTests.StepDefinitions
{
    [Binding]
    public class HandteringAfKontakterICustomerKlassenStepDefinitions
    {
        private Customer customer;

        [Given("en kunde uden kontakter")]
        public void GivenEnKundeUdenKontakter()
        {
            customer = new Customer();
        }

        [When("kunden tilføjer en ny kontakt med email {string}")]
        public void WhenKundenTilfojerEnNyKontaktMedEmail(string p0)
        {
            customer.AddContact(new Contact("Brian", p0));
        }

        [Then("skal kontakten være tilføjet til kundens kontakter")]
        public void ThenSkalKontaktenVaereTilfojetTilKundensKontakter()
        {
            Assert.That(1, Is.EqualTo(customer.Contacts.Count));
        }

        [Given("en kunde med en eksisterende kontakt med email {string}")]
        public void GivenEnKundeMedEnEksisterendeKontaktMedEmail(string p0)
        {
            customer = new Customer();
            customer.AddContact(new Contact("Brian", p0));
        }

        [When("kunden forsøger at tilføje en anden kontakt med samme email {string}")]
        public void WhenKundenForsogerAtTilfojeEnAndenKontaktMedSammeEmail(string p0)
        {
            customer.AddContact(new Contact("Brian", p0));
        }

        [Then("skal den nye kontakt ikke tilføjes til kundens kontakter")]
        public void ThenSkalDenNyeKontaktIkkeTilfojesTilKundensKontakter()
        {
            Assert.That(1, Is.EqualTo(customer.Contacts.Count));
        }

        [Given("en kunde med nogle kontakter")]
        public void GivenEnKundeMedNogleKontakter()
        {
            customer = new Customer();
            customer.AddContact(new Contact("Brian", "brhv@ucn.dk"));
            customer.AddContact(new Contact("Dan", "dahg@ucn.dk"));
        }

        [When("kunden forsøger at tilføje en kontakt der er null")]
        public void WhenKundenForsogerAtTilfojeEnKontaktDerErNull()
        {
            
        }

        [Then("skal der udløses en fejl angående forsøg på at tilføje en null kontakt")]
        public void ThenSkalDerUdlosesEnFejlAngaendeForsogPaAtTilfojeEnNullKontakt()
        {
            
        }
    }
}
