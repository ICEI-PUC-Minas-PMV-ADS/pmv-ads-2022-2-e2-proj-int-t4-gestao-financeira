export class CommunicateAPI {
  #url;
  #endPoint;
  #idUser;

  constructor(endPoint, idUser) {
    this.#url = `http://localhost:5055/api`;
    this.#idUser = idUser;
    this.#endPoint = endPoint;
  }

  async get() {
    const options = {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    };

    try {
      fetch(`${this.#url}/${this.#endPoint}`, options)
        .then((value) => {
          return value;
        })
        .catch((error) => {
          throw new Error(error);
        });
    } catch (error) {
      throw new Error(error);
    }
  }

  post(value) {
    const options = {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(value),
    };

    try {
      fetch(`${this.#url}/${this.#endPoint}/${this.#idUser}`, options)
        .then((value) => {
          return value;
        })
        .catch((error) => {
          throw new Error(error);
        });
    } catch (error) {
      throw new Error(error);
    }
  }

  delete(value) {
    const options = {
      method: "DELETE",
      headers: {
        "Content-Type": "application/json",
      },
    };

    try {
      fetch(`${this.#url}/${this.#endPoint}/${this.#idUser}`, options)
        .then((value) => {
          return value;
        })
        .catch((error) => {
          throw new Error(error);
        });
    } catch (error) {
      throw new Error(error);
    }
  }

  put(value) {
    const options = {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
        Accept: "application/json",
        "Access-Control-Allow-Origin": "*",
      },
      body: JSON.stringify(value),
    };

    try {
      fetch(`${this.#url}/${this.#endPoint}/${this.#idUser}`, options)
        .then((value) => {
          return value;
        })
        .catch((error) => {
          throw new Error(error);
        });
    } catch (error) {
      throw new Error(error);
    }
  }
}
