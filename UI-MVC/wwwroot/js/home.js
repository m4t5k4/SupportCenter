"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/generalHub").build();

var tickets;
var count;
var total = document.getElementById("total").innerHTML;
var opgelost = document.getElementById("opgelost").innerHTML;
var onopgelost = document.getElementById("onopgelost").innerHTML;


connection.start().then(function(){
    connection.invoke("ServerSendUpdate")
}).catch(function (err) {
    return console.error(err.toString());
});
/*
connection.invoke("ServerSendUpdate", function (data) {
    total = data[0];
    opgelost = data[1];
    onopgelost = data[2];
});*/

/*
connection.on("ClientReceiveUpdate", function (data) {
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
});*/

connection.on("ClientReceiveUpdate", function (data) {
    total = data[0];
    opgelost = data[1];
    onopgelost = data[2];
})