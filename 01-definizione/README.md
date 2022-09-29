# Definizione

## 1. *Bisogni* esposti nella traccia:
> - Controllo degli accessi (Nome Utente,Password).
> - Controllo della validità della email.
> - Dati gestiti in modo sicuro e rispettoso la privacy degli utenti.
> - Istituto di provenienza e vari dati scolastici (voti,media scolastica).
> - Eventuale accesso a due fattori.

## 2. *Risposte* tecnologiche ai bisogni individuati:
> - Per sviluppare il nostro sito web andremo ad utilizzare "**Visual Studio 2019**", tramite il quale  andremo a gestire i controlli, basati su (Nome Utente e Password) un controllo della validità della mail ed eventualmente accesso a due fattori in ASP.NET Core.
> - Per il controllo degli accessi utilizzeremo un database secondario.
> - Per il controllo della validità della email utilizzeremo la classe **MailAddress** di Microsoft.
> - Utilizzando la libreria "using Microsoft.AspNetCore.Identity" è di fatto possibile utilizzare un servizio di login a due fattori (2FA) che permette alle scuole di accedere alla pagina amministratore, dove potranno essere inseriti i dati e potrà essere gestito il proprio istituto.

## 3. *Gap* di conoscenza rilevati nei membri del gruppo:
> - Creazione di un database partendo da un diagramma UML ("Entity Framework");
> -	Gestione e comparazione dei dati contenuti nel database;
> - Autenticazione a due fattori ("using Microsoft.AspNetCore.Identity");
> -	Inserimento di una pagina amministratore differente da quella utente.




