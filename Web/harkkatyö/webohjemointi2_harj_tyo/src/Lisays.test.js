import {getByText, render, screen} from '@testing-library/react'
import userEvent from '@testing-library/user-event'
import Lisays from './Lisays'

import {fireEvent} from '@testing-library/react'

describe("Testi napille", ()=> {
    render(<Lisays/>);
        test("Testaan nappi..", async() => { 
                      
                const alertMock = jest.spyOn(window,'alert').mockImplementation(); 
               
                await userEvent.click(screen.getByTestId("btn1"));
                expect(alertMock).toHaveBeenCalledTimes(1)
              })

        });
