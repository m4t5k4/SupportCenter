"use strict";

//var generalHub = $.connection.generalHub;
var connection = new signalR.HubConnectionBuilder().withUrl("/generalHub").build();

var tickets;
var count;
var total = document.getElementById("total");
var opgelost = document.getElementById("opgelost");
var onopgelost = document.getElementById("onopgelost");

connection.start().then(function(){
    connection.invoke("ServerSendUpdate");
}).catch(function (err) {
    return console.error(err.toString());
});

connection.on("ClientReceiveUpdate", function (data) {
    console.log(data);
    total.innerHTML = data[0];
    opgelost.innerHTML = data[1];
    onopgelost.innerHTML = data[2];
});