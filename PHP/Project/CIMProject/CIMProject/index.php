<?php
class Person
{
    
    public $age;
    public function eat()
    {
       echo 'I am eating'; 
    }
}

$xiaoming = new Person();
var_dump($xiaoming);