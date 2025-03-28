Feature: Håndtering af kontakter i Customer klassen

  Scenario: Tilføje en ny kontakt til Customer
    Given en kunde uden kontakter
    When kunden tilføjer en ny kontakt med email 'eksempel@email.dk'
    Then skal kontakten være tilføjet til kundens kontakter

  Scenario: Forhindre tilføjelse af en kontakt med en eksisterende email
    Given en kunde med en eksisterende kontakt med email 'eksempel@email.dk'
    When kunden forsøger at tilføje en anden kontakt med samme email 'eksempel@email.dk'
    Then skal den nye kontakt ikke tilføjes til kundens kontakter

  Scenario: Fejl ved tilføjelse af en null kontakt
    Given en kunde med nogle kontakter
    When kunden forsøger at tilføje en kontakt der er null
    Then skal der udløses en fejl angående forsøg på at tilføje en null kontakt
