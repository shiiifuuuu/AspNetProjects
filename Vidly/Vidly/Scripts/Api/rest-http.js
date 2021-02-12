class HttpApi {
    //http get request
    static async Get(url) {
        let response = await fetch(url);
        let result = await response.json();
        return result;
    }

    //http post/create request
    static async Post(url, data) {
        let response = await fetch(url,
            {
                method: 'POST',
                headers: {
                    'content-type': 'application/json'
                },
                body: JSON.stringify(data)
            });
        let result = await response.json();
        return result;
    }

    //http put/update request
    static async Put(url, data) {
        let response = await fetch(url,
            {
                method: 'PUT',
                headers: {
                    'content-type': 'application/json'
                },
                body: JSON.stringify(data)
            });
        let result = await response.json();
        return result;
    }

    //http delete request
    static async Delete(url) {
        let response = await fetch(url,
            {
                method: 'DELETE',
                headers: {
                    'content-type': 'application/json'
                }
            });
        let result = await response.json();
        return result;
    }
}