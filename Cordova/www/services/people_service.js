angular.module('myApp').service('peopleService', function () {

    this.people = [
        { firstname: 'Simona', lastname: 'Morasca', img: 'photo01.jpg' },
        { firstname: 'Mitsue', lastname: 'Tollner', img: 'photo02.jpg' },
        { firstname: 'Leota', lastname: 'Dilliard', img: 'photo03.jpg' },
        { firstname: 'Sage', lastname: 'Wieser', img: 'photo04.jpg' },
        { firstname: 'Kris', lastname: 'Marrier', img: 'photo05.jpg' },
        { firstname: 'Minna', lastname: 'Amigon', img: 'photo06.jpg' },
        { firstname: 'Abel', lastname: 'Maclead', img: 'photo07.jpg' },
        { firstname: 'Kiley', lastname: 'Caldarera', img: 'photo08.jpg' },
        { firstname: 'Graciela', lastname: 'Ruta', img: 'photo09.jpg' },
        { firstname: 'Cammy', lastname: 'Albares', img: 'photo10.jpg' },
        { firstname: 'Mattie', lastname: 'Poquette', img: 'photo11.jpg' },
        { firstname: 'Meaghan', lastname: 'Garufi', img: 'photo12.jpg' }
        //{ firstname: 'Gladys', lastname: 'Rim', img: 'photo13.jpg' },
        //{ firstname: 'Yuki', lastname: 'Whobrey', img: 'photo14.jpg' },
        //{ firstname: 'Fletcher', lastname: 'Flosi', img: 'photo15.jpg' },
        //{ firstname: 'Bette', lastname: 'Nicka', img: 'photo16.jpg' }
    ];

    // Retourne le message reçu précédé de la date et de l'heure,
    // avec le niveau d'alerte voulu
    this.get_people = function () {
        return this.people;
    };

    this.get = function(index) {
        return this.people[index];
    };

});