function TableClass(props){


    const otsikot = props.headers.map((header) => <th key={header}>{header}</th>);
    const nimet = props.items.map(item =>(
        <tr key={item}>



            <td>  {item.nimi}    </td>

            <td>{item.osoite}</td> 
            <td> {item.aloitusvuosi}</td> 
            <td> {item.lopettanut}</td> 
           </tr> 



        )

    );

    return (
        <table>
            <tbody>
        <tr>
              {otsikot}
        </tr> 

         {nimet}

         </tbody>
         </table>

    );
}


export default TableClass;