"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/basketHub").build();

connection.on("RecievedAddToBasket", function (basket) {
    console.log(basket);
});

connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

$(".add-to-basket").click(function (event) {
    var id = $(this).data("id");
    var qty = $(this).data("qty");
    connection.invoke("AddToBasket", id, qty).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});