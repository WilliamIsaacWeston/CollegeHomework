//set main namespace
goog.provide('blackout');


//get requirements
goog.require('lime.Director');
goog.require('lime.Scene');
goog.require('lime.Layer');
goog.require('lime.Circle');
goog.require('lime.Label');
goog.require('lime.animation.Spawn');
goog.require('lime.animation.FadeTo');
goog.require('lime.animation.ScaleTo');
goog.require('lime.animation.MoveTo');
goog.require('lime.audio.Audio');
  
  var pieces = [];
  var winMsg;
  var click;
  var applause;

// entrypoint
blackout.start = function(){

	var director = new lime.Director(document.body,500,600);
	var scene = new lime.Scene();
  
  var small = 4;
  var medium = 6;
  var large = 8;
  var size = small;
  
  var title = new lime.Label().setSize(800,70).setFontSize(60).setText('Blackout!')
    .setPosition(250,50);
  var sizeLabelStatic = new lime.Label().setSize(200,40).setFontSize(32).setText('Size')
    .setPosition(70,550);
  var sizeLabel = new lime.Label().setSize(150,40).setFontSize(32).setText('Small')
    .setPosition(180,550).setFill(128,128,128,1);
  var newGame = new lime.Label().setSize(200,40).setFontSize(32).setText('New Game')
    .setPosition(360,550).setFill(128,128,128,1);
  winMsg = new lime.Label().setSize(200,40).setFontSize(40).setText('YOU WIN!')
    .setPosition(250,300).setOpacity(0).setFontColor('#c00').setFontWeight('bold');
  click = new lime.audio.Audio('click.mp3');
  applause = new lime.audio.Audio('applause.mp3');
  var newGameSFX = new lime.audio.Audio('newgame.mp3');
  var sizeSFX = new lime.audio.Audio('size.mp3');
    
  var board = createBoard(size);
	
    //add target and title to the scene
    scene.appendChild(board);
    scene.appendChild(title);
    scene.appendChild(sizeLabel);
    scene.appendChild(sizeLabelStatic);
    scene.appendChild(newGame);
    scene.appendChild(winMsg);
    
    //add some interaction
    goog.events.listen(sizeLabel,['click','touchstart'],function(e){
      sizeSFX.play();
      switch(size) {
        case small:
          size = medium;
          sizeLabel.setText('Medium');
          break;
      case medium:
          size = large;
          sizeLabel.setText('Large');
          break;
      case large:
          size = small;
          sizeLabel.setText('Small');
          break;
      }
    });
    
    goog.events.listen(newGame,['click','touchstart'],function(e){
      newGameSFX.play();
      if (applause.isPlaying())
        applause.stop();
      scene.removeChild(board);
      board = createBoard(size);
      scene.appendChild(board);
      scene.setChildIndex(board, 0)
      winMsg.setOpacity(0);
    });

	director.makeMobileWebAppCapable();

	// set current scene active
	director.replaceScene(scene);

}

function createBoard(boardSize) {
  var target = new lime.Layer().setPosition(250,300);
  
  pieces = [];
  
  var pieceSize = 50;
  var x = y = (boardSize-1) * pieceSize/-2;
  
  var board = new lime.Sprite().setSize((pieceSize*boardSize),(pieceSize*boardSize))
    .setFill('#d3d3d3');

    target.appendChild(board);
    
    for (var i=0; i<boardSize; i++) {
      var d1 = [];
      
      for (var j=0; j<boardSize; j++) {
        var thisPiece = new lime.Circle().setSize(35,35).setPosition(x,y)
        
        if (Math.random() > 0.5)
          thisPiece.setFill('#000000');
        else
          thisPiece.setFill('#FFFFFF');
        
        target.appendChild(thisPiece);
        bindClick(thisPiece, pieces, winMsg, click, applause);
        d1[j] = thisPiece;
        x += pieceSize;
      }
      pieces[i] = d1;
      y += pieceSize; 
      x = (boardSize-1) * pieceSize/-2;      
    }
    
    return target;
}

function bindClick(p, pieces, msg, c, a) {
  var ps = pieces;
  var text = msg;
  var click = c;
  var app = a;
  
  goog.events.listen(p,['click','touchstart'],function(e){
    var x, y;
    
    click.play();
    
    for (var i=0; i<ps.length; i++) {
      for (var j=0; j<ps.length; j++) {
        if (ps[i][j] == p) {
          x = i;
          y = j;
        }
      }
    }
    
    for (var i=-1; i<=1; i++){
      for (var j=-1; j<=1; j++){
        if ((x+i) >= 0 && (x+i) < ps.length && (y+j) >= 0 && (y+j) < ps.length)
          if (ps[x+i][y+j].getFill().getRgba() == '255,255,255,1')
            ps[x+i][y+j].setFill('#000000');
          else
            ps[x+i][y+j].setFill('#FFFFFF');
      }
    }
    
    checkIfWon(text, app);
  });
}

function checkIfWon(msg, applause) {
  var won = true;
  
  for (var i=0; i<pieces.length; i++) {
    for (var j=0; j<pieces.length; j++) {
      if (pieces[i][j].getFill().getRgba() == '255,255,255,1') {
        won = false;
      }
    }
  }
  
  if(won) {
    applause.play();
    msg.runAction(new lime.animation.Spawn(
      new lime.animation.FadeTo(1).setDuration(.2),
      new lime.animation.ScaleTo(2.5).setDuration(.8)
    ));
  }
}


//this is required for outside access after code is compiled in ADVANCED_COMPILATIONS mode
goog.exportSymbol('blackout.start', blackout.start);
