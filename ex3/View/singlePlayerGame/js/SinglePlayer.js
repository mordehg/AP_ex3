(function ($) {
        $.fn.drawMaze = function (mazeData, startRow, startCol, exitRow, exitCol,
                                  playerImage, exitImage, ableToMove, makeMove) {

            var myCanvas = document.getElementById("mazeCanvas");
            var context = mazeCanvas.getContext("2d");
            var rows = mazeData.length;
            var cols = mazeData[0].length;
            var cellWidth = mazeCanvas.width / cols;
            var cellHeight = mazeCanvas.height / rows;
            var startImg = new Image();
            startImg.src = "/View/images/start here.png";

            for (var i = 0; i < rows; i++) {
                for (var j = 0; j < cols; j++) {
                    if (mazeData[i][j] == 1) {
                        context.fillRect(cellWidth * j, cellHeight * i,
                       cellWidth, cellHeight);
                    }
                }
            }
            startImg.onload = function () {
                context.drawImage(startImg, cellWidth * startCol, cellHeight * startRow,
                       cellWidth, cellHeight);
            };
            exitImage.onload = function () {
                context.drawImage(exitImage, cellWidth * exitCol, cellHeight * exitRow,
                               cellWidth, cellHeight);
            };
        }
    })(jQuery);

    var mazeName = document.getElementById("name").value;
    var rows = parseInt(document.getElementById("rows").value);
    var cols = parseInt(document.getElementById("cols").value);
    var mazeData = new Array();
    for (var i = 0; i < rows; i++) {
        mazeData[i] = new Array(cols);
    }
    var startRow, startCol;
    var exitRow, exitCol;
    var mazeJason = $.getJSON("api/Maze/" + mazeName + "/" + rows + "/" + cols).done(function (data) {
        var strMaze = data.Maze;
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                mazeData[i][j] = parseInt(strMaze.charAt(i * cols + j));
            }
        }
        startRow = data.Start.Row;
        startCol = data.Start.Col;
        exitRow = data.End.Row;
        exitCol = data.End.Col;
    });
    var playerIcon = new Image();
    playerIcon.src = "/View/images/player icon.png";
    var exit = new Image();
    exit.src = "/View/images/finish line.png";
    var makeAMove = function (direction, playerRow, playerCol) {
        switch (direction) {
            case '38':
                playrrRow++;
                break;
            case '40':
                playerRow--;
                break;
            case '37':
                playerCol++;
                break;
            case '39':
                playerCol--;
                break;
            default:
                break;
        }
    };    $("#startBtn").click(function () {
        $("#mazeCanvas").drawMaze(mazeData, startRow, startCol, exitRow,        exitCol, playerIcon, exit, true, makeAMove);
    });