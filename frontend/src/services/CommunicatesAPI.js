export class CommunicateAPI {

    #url;
    #idUser;

    constructor(endPoint, idUser) {
        this.#url = `http://API/${endPoint}`;
        this.#idUser = idUser;
    };

    async get() {

        const options = {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
            }
        };

        try {
          
            fetch(`${this.#url}/${this.#idUser}`, options)
            .then((value) => {

                return value;

            })
            .catch((error) => {
                throw new Error(error);
            });

        } catch (error) {
            throw new Error(error);
        };
    };

    post(value) {

        const options = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(value),
        };

        try {
          
            fetch(`${this.#url}`, options)
            .then((value) => {

                return value;

            })
            .catch((error) => {
                throw new Error(error);
            });

        } catch (error) {
            throw new Error(error);
        };
    };

    delete(value) {
        const options = {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json',
            }
        };

        try {
          
            fetch(`${this.#url}/${this.#idUser}`, options)
            .then((value) => {

                return value;

            })
            .catch((error) => {
                throw new Error(error);
            });

        } catch (error) {
            throw new Error(error);
        };
    };

    put(value) {
        const options = {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json',
                'Access-Control-Allow-Origin': '*'
            },
            body: JSON.stringify(value),
        };

        try {
          
            fetch(`${this.#url}/${this.#idUser}`, options)
            .then((value) => {

                return value;

            })
            .catch((error) => {
                throw new Error(error);
            });

        } catch (error) {
            throw new Error(error);
        };
    };

};