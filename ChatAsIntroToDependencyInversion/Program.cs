using ChatAsIntroToDependencyInversion;

/*
 * Eks 1 - chat: Dependency Inversion Principle
 *
 * Eks 2 - søke i filer - Single Responsibility Principle og Dependency Injection (teknikk)
 *
 *
 * Pause til 10:30
 */


var server = new ChatServer();

var client1 = new ChatClient("Per", server);
var client2 = new ChatClient("Pål", server);
var client3 = new ChatClient("Espen", server);

client1.Say("Halla");
// Pål og Espen får beskjed "Per sier Halla"

client2.Say("Helle");
// Per og Espen får beskjed "Pål sier Helle"

client3.Say("Hollo");
// Per og Pål får beskjed "Espen sier Hollo"