import React, { useState, useEffect } from 'react';
import Table from 'react-bootstrap/Table';


function Henkilot(props) {
    const [data, setData] = useState([]);
    const [causeError, setErrorCause] = useState(false);

    const [url, setUrl] = useState('');
    const [isLoading, setIsLoading] = useState(false); // json-server --watch db.json --port 3004 --delay 2000



    useEffect(() => {

        const fetchData = async () => {
            setUrl('http://localhost:4000/Hyllyt');
            setIsLoading(true);
            const response = await fetch(url);
            setData(await response.json());
            setIsLoading(false);

        };

        fetchData();

    }, [url]);



    return (

        <div>




            {isLoading ? <div>Loading...</div> :
                (<Table striped bordered hover size="lg">
                    <tbody>
                        <tr>
                            <th>Hylly id</th>
                            <th>Nimi</th>
                            <th>Lisätieto</th>
                        </tr>



                        {data.map((Hylly) => (
                            <tr key={Hylly.id}>
                                <td>{Hylly.id}</td>
                                <td>{Hylly.Nimi}</td>
                                <td>{Hylly.Lisätieto}</td>
                            </tr>))}
                    </tbody>
                </Table>)}

            {(data.length === 0) && (isLoading === false) ? <div>Annetuilla hakuehdoilla ei löytynyt dataa.</div> : null}


        </div>
    );
}

export default Henkilot



