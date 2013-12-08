;
(function ($, SignalRDemo, undefined) {
    
    SignalRDemo.Chat = {
        Hub: null,
        AddMessage: addMessage,
        SendMessage: sendMessage,
        Init: init
    };

    return SignalRDemo.Chat;

    function init(chatHub) {
        this.Hub = chatHub;
        $('#btn_sendMessage').click(this.SendMessage);
    }

    function sendMessage() {
        var mess = $('#chat_message').val();
        
        // Call the Send method on the hub. 
        SignalRDemo.Chat.Hub.server.send("User", mess);
        // Clear text box and reset focus for next comment. 
        $('#chat_message').val('').focus();
    }

    function addMessage(chatContent) {
        $('#chatHistory').prepend('<p><strong>' + chatContent.UserName + ': </strong>' + chatContent.Content + '  - (' + chatContent.LogTime + ')</p>');
    }

})(jQuery, window.SignalRDemo = window.SignalRDemo || {});