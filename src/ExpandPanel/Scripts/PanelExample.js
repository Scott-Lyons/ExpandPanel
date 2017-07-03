var Panel = {
    Expand: function(teamId) {
        var team = $("#Team" + teamId),
            url = team.data("request-url");

        $.get(url, function(data) {
            team.html(data);
            team.slideToggle("slow", function() {});
        });
    }
}