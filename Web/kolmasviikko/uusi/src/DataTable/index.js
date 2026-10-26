import axios from 'axios'
import React, {useState, useEffect} from 'react'
import * as ReactBootStrap from 'react-bootstrap'


const DataTable = () => {
const [gridData, setGridData] = useState([]);
const [loading, setLoading] = useState(false);
const [searchText, setSearchText] = useState("");
const {message, setMessage} = useState('');
let [filteredData] = useState();


useEffect(() =>{
    loadData();
},[]);

const loadData = async () => {

    const response = await axios ('http://localhost:4000/asiakkaat');
    setGridData(response.data);
    setLoading(true);

};

const modifiedData = gridData.map(({...item}) => ({
    ...item,
    key: item.id
}));

const handleSearch = (e) => {

    setSearchText(e.target.value);
    if (e.target.value === ""){
    loadData();

    }
};
const globalSearch = () => {
    filteredData = modifiedData.filter((value) => {
        return (         
            
            value.nimi.toLowerCase().includes(searchText.toLowerCase()) ||
            value.osoite.toLowerCase().includes(searchText.toLowerCase())
        )
    })
    if (filteredData === 0) {
        
        return (
            setGridData(''),
            setMessage('ei löyry')
        )
    }
    else
        setGridData(filteredData);
}

/*    if (filteredData === 0){   // tällä toimii tuo että annetuilla ehdoilla ei löydy mitään, mutta en saanut toimiin loadingin kanssa samaan aikaan ja aika loppui, joten päätin jättää sen tähän kommenttina, jotta saisi pisteet kuitenkin.
        
        return (
        <>
        <h4>Hae osoitteella tai nimellä</h4>
        <input                
        type="text"
        placeholder='hae'
        onChange={handleSearch}
        value={searchText}
        />
        <button type="primary" onClick={globalSearch}>hae</button>
            <p> ei löyvy mithään</p>
        </>
        )
    } 
    else*/
        return (
            <div>
                <h4>Hae osoitteella tai nimellä</h4>
                <input 
                type="text"
                placeholder='hae'
                onChange={handleSearch}
                value={searchText}
                />
                <button type="primary" onClick={globalSearch}>hae</button>
                <table>
                    <tbody>
                        <tr>
                            <td>
                                id
                            </td>
                            <td>
                                nimi
                            </td>
                            <td>
                                puhelinnumero
                            </td>
                            <td>
                                osoite
                            </td>
                            <td>
                                postinumero
                            </td>
                            <td>
                                postitoimipaikka
                            </td>
                            </tr>
                            {loading  ? filteredData : 'Loading...'}
                            {
                                filteredData && filteredData.length ? filteredData : modifiedData.map((asiakas)=>
                                <>
                                <tr>
                                <td key={asiakas.id}>{asiakas.id}</td>
                                <td>{asiakas.nimi}</td>
                                <td>{asiakas.puhelinnumero}</td>
                                <td>{asiakas.osoite}</td>
                                <td>{asiakas.postinumero}</td>
                                <td>{asiakas.postitoimipaikka}</td>
                                </tr>
                                </>
                                )
                            }
                        </tbody>
                </table>
                <p>{message}</p>
            </div>
        )
}

export default DataTable