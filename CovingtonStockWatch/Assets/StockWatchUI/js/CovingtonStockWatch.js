function gotoStockViewerScreen(){
    console.log("Stock Viewer Screen");
    //Show Stock Viewer Screen
    $("#StockViewerScreen").css("visibility", "visible");
    $("#StockViewerScreen").show();
    
    //Hide Notification Viewer Screen
    $("#NotificationViewerScreen").css("visibility", "hidden");
    $("#NotificationViewerScreen").hide();

    //Hide Stock Manager Screen
    $("#StockManagererScreen").css("visibility", "hidden");
    $("#StockManagererScreen").hide();

    //Hide Notification Manager Screen
    $("#NotificationManagerScreen").css("visibility", "hidden");
    $("#NotificationManagerScreen").hide();

}

function gotoNotificationViewerScreen(){
    console.log("Notication Viewer Screen");

    //Hide Stock Viewer Screen
    $("#StockViewerScreen").css("visibility", "hidden");
    $("#StockViewerScreen").hide();

    //Show Notification Viewer Screen
    $("#NotificationViewerScreen").css("visibility", "visible");
    $("#NotificationViewerScreen").show();

    //Hide Stock Manager Screen
    $("#StockManagererScreen").css("visibility", "hidden");
    $("#StockManagererScreen").hide();

    //Hide Notification Manager Screen
    $("#NotificationManagerScreen").css("visibility", "hidden");
    $("#NotificationManagerScreen").hide();
}