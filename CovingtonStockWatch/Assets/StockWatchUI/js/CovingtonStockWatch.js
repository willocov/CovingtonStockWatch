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

function gotoStockManagerScreen(){
    console.log("Stock Manager Screen");

    //Hide Stock Viewer Screen
    $("#StockViewerScreen").css("visibility", "hidden");
    $("#StockViewerScreen").hide();

    //Show Notification Viewer Screen
    $("#NotificationViewerScreen").css("visibility", "hidden");
    $("#NotificationViewerScreen").hide();

    //Hide Stock Manager Screen
    $("#StockManagererScreen").css("visibility", "visible");
    $("#StockManagererScreen").show();

    //Hide Notification Manager Screen
    $("#NotificationManagerScreen").css("visibility", "hidden");
    $("#NotificationManagerScreen").hide();
}

function gotoNotificationManagerScreen(){
    console.log("Notification Manager Screen");

    //Hide Stock Viewer Screen
    $("#StockViewerScreen").css("visibility", "hidden");
    $("#StockViewerScreen").hide();

    //Show Notification Viewer Screen
    $("#NotificationViewerScreen").css("visibility", "hidden");
    $("#NotificationViewerScreen").hide();

    //Hide Stock Manager Screen
    $("#StockManagererScreen").css("visibility", "hidden");
    $("#StockManagererScreen").hide();

    //Hide Notification Manager Screen
    $("#NotificationManagerScreen").css("visibility", "visible");
    $("#NotificationManagerScreen").show();
}

function HandleSwipe(direction){
    //This function handles screen navigation with swiping behavior
    //Allows user to swipe between viewer screens
    //Swiping right on a manager screen will return to the respective viewer screen

    if($("#StockViewerScreen").is(":visible")){
        if(direction == "left"){
            gotoNotificationViewerScreen();
        }
    }
    else if($("#NotificationViewerScreen").is(":visible")){
        if(direction == "right"){
            gotoStockViewerScreen();
        }
    }
    else if($("#StockManagerScreen").is(":visible")){
        if(direction == "right"){
            gotoStockViewerScreen();
        }
    }
    else if($("#NotificationManagerScreen").is(":visible")){
        gotoNotificationViewerScreen();
    }
}

//Profile Related Functions
function LoadProfiles(){
    
}

function SaveProfiles(){

}

function AddProfile(){

}

function RemoveProfile(){

}

function ProfileButtonClicked(){
    console.log("Profile Button Clicked");
    
    
}

//Stock Related Functions
function AddButtonClicked(){
    if($("#StockViewerScreen").is(":visible")){
        console.log("Add Stock Button Clicked");
        gotoStockManagerScreen();
    }
    else if($("#NotificationViewerScreen").is(":visible")){
       console.log("Add Notification Button Clicked");
       gotoNotificationManagerScreen();
    }
    else{
        console.log("Add Button Pressed from Invalid Screen");
        gotoStockViewerScreen();
    }
}

function AddStock(){}

function RemoveStock(){}

function ClearAllStocks(){}

function LoadStocks(){}

//Notification Related Functions
function AddNotification(){}

function RemoveNotification(){}

function ClearAllNotifications(){}

function LoadNotifications(){}
