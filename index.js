const canvas = document.getElementById('canvas');
const ctx = canvas.getContext('2d');

// run at 60fps
const fps = 60;
const interval = 1000 / fps;

var y = 0;

var background = '#eeeeee';

var delta = 0;
var lastTime = 0;

var currentWidth;
var currentHeight;

const Triangle = {
    x: 0,
    y: 0,
    width: 0,
    height: 0,
    color: '#00ff00',
    draw: function() {
        ctx.fillStyle = this.color;
        // draw triangle
        ctx.beginPath();
        ctx.moveTo(this.x + (this.width / 2), this.y);
        ctx.lineTo(this.x, this.y + this.height);
        ctx.lineTo(this.x + this.width, this.y + this.height);
        ctx.closePath();
        ctx.fill();

    },
    update: function() {
        this.draw();
    },
    init: function() {
        this.x = Math.random() * currentWidth;
        this.y = Math.random() * currentHeight;
        var scale = Math.random() * 0.2;
        this.width = scale * currentWidth * 1.2;
        this.height = scale * currentHeight;
    }
}

var Triangles = []

var TriangleCount = 100;

function Update(timestamp) {
    currentWidth = canvas.width;
    currentHeight = canvas.height;

    ctx.clearRect(0, 0, canvas.width, canvas.height);

    if(TriangleCount > Triangles.length) {
        for(var i = Triangles.length; i < TriangleCount; i++) {
            Triangles.push(Object.create(Triangle));
            Triangles[i].init();

        }
    } else if(TriangleCount < Triangles.length) {
        for(var i = Triangles.length; i > TriangleCount; i--) {
            Triangles.pop();
        }
    }

    ctx.fillStyle = background;
    ctx.fillRect(0, 0, currentWidth, currentHeight);

    for(var i = 0; i < Triangles.length; i++) {
        var thisTriangle = Triangles[i];
        thisTriangle.draw();
    }
}

setInterval(function() {
    var now = Date.now();
    delta = now - lastTime;
    lastTime = now;
    Update(now);
}, interval);