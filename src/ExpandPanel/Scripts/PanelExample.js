var Panel = {
    Expand: function(teamId) {
        var url = "users?TeamId=" + teamId;
        var team = $("#Team" + teamId);
        $.get(url, function(data) {
            team.html(data);
            team.slideToggle("slow", function() {});
        });
    }
}