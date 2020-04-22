class Data{

    names = ["Béla", "Károly", "Róbert", "Mária", "Lajos", "Izabella", "Anett", "Zsófia", "Tünde", "Dénes"];
    exams = [];

    constructor(){
        this.createExams();
    }
    
    getNames(){
        return this.names;
    }

    getExams(){
        return this.exams;
    }

    createExams(){
        for(let i= 0; i <60; i++){
            this.exams.push("exam " + (i+1));
        }
    }

}

class ExamResults extends Data{

    results = [];

    constructor(){
        super();        
        this.createResults();
    }

    getResults(){
        return this.results;
    }

    createResults(){
        const names = this.getNames();
        const exams = this.getExams();

        for (let i = 0; i < exams.length; i++) {
            for(let j = 0; j < names.length; j++){
                
                const result = 
                {
                    name : names[j],
                    exam : exams[i],
                    rating : this.createRating()
                }

                this.results.push(result);
            }            
        }
    }

    createRating(){
        return Math.ceil(Math.random()*100);
    }

}