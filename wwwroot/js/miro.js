"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/miroHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("StickyMessage", function (message) {
    var li = document.createElement("li");
        li.textContent = `${message}`;
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {

    var jsonString = '{"event":"Miro Update"}';
    //var user = document.getElementById("userInput").value;
    //var message = document.getElementById("messageInput").value;
    //connection.invoke("SendMessage", user, message).catch(function (err) {
    //    return console.error(err.toString());
    //});

    connection.invoke("SendSticky", jsonString).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();
});