#pragma strict

var enemy : GameObject;

var nextSpawn:float = 0.0;
var spawnInterval:float = 1.0;


var maxEnemies:int = 20;
var totalEnemies:int = 1;

function Start(){
    //On the start set the time since the start of the game then add the spawn interval to it.
    nextSpawn = Time.time + spawnInterval;
}

function Update(){
    //Check if the time is greater than the next spawn time and that the enemies limit hasn't been hit
    if(Time.time > nextSpawn && totalEnemies < maxEnemies){
        nextSpawn = Time.time + spawnInterval;
        spawnEnemy();
        
    }

}

function spawnEnemy(){
//set the enemy to appear at the position of the object the script is attached to
	var xrandpos = 5*(Random.value - Random.value);
	var yrandpos = 3*(Random.value - Random.value);

    Instantiate(enemy, transform.position + Vector3(xrandpos,yrandpos,0), transform.rotation);
    totalEnemies++;
}