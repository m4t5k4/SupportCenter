"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/homeHub").build();

//Disable send button until connection is established
var tickets;
var count;
var total = document.getElementById("total").innerHTML;
var opgelost = document.getElementById("opgelost").innerHTML;
var onopgelost = document.getElementById("onopgelost").innerHTML;

connection.on("ReceiveUpdate", function () {
    $.ajax('/api/Tickets', {type: 'GET', dataType: 'json'})
        .done(function(data) { tickets = data});
    total = tickets.length;
    count = 0;
    tickets.forEach(function (obj) {
        if (obj.state == 4){
            count++;
        }
    })
    opgelost = count;
    onopgelost = total - count;
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    connection.invoke("SendMessage", user, message)
});