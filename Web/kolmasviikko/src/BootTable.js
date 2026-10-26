import React, {useEffect, useState, useRef} from 'react'
import axios from 'axios'
import * as ReactBootStrap from 'react-bootstrap'
import './App.css';



const BootTable = () => {
    
    const[posts, setPosts] = useState({asiakkaat : []})
    const [query, setQuery] = useState('')
    const [loading, setLoading] = useState(false);


    
    useEffect((e)=> {
        const fetchPostList = async () => {
            const {data} = await axios('http://localhost:4000/Asiakkaat?nimi_like='+ query)
            setLoading(true)
            setPosts({data: data})
            console.log(data)
        }
        fetchPostList()
    }, [query])
    
    function Loading(loading){
        if (loading == true){
            console.log("loading...")
            return(
                <div>
                    <p>
                        Loading...
                    </p>
                </div>
            )
        }
    }


        return (
            <div>
                    <input type="text" placeholder='Hae' onChange={(e) => setQuery(e.target.value)}/>
                    <ReactBootStrap.Table striped bordered hover variant="dark">
                <thead>
                <tr>
                    <th>id</th>
                    <th>nimi</th>
                    <th>puhelinnumero</th>
                    <th>osoite</th>
                    <th>postinumero</th>
                    <th>postitoimipaikka</th>
                </tr>
                </thead>
                <tbody>
                    {
                        posts.asiakkaat && posts.asiakkaat.map((item) =>(
                            <tr key={item.id}>
                            <td>{item.id}</td>
                            <td>{item.nimi}</td>
                            <td>{item.puhelinnumero}</td>
                            <td>{item.osoite}</td>
                            <td>{item.postinumero}</td>
                            <td>{item.postitoimipaikka}</td>
                            <td><button>Delete</button> </td>
                        </tr>
                        ))
                    }
                </tbody>
            </ReactBootStrap.Table>
        </div>
        )
    }


export default BootTable