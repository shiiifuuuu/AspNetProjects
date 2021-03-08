class HttpRest {

    //Get
    static async Get(url) {
        let response = await fetch(url);
        let result = await response.json();
        return result;
    }

    //Post
    static async Post(url, data) {
        let response = await fetch(url,
            {
                method: 'POST',
                headers: {
                    'Content-type': 'application/json'
                },
                body: JSON.stringify(data)
            });
        let result = await response.json();
        return result;
    }
}