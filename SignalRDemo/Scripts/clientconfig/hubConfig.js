$(function () {

    $.connection.ChatHub.client.broadcastMessage = function(value) {
        SignalRDemo.Chat.AddMessage(value);
    };

    $.connection.hub.start().done(function () {
        SignalRDemo.Chat.Init($.connection.ChatHub);
    });
});