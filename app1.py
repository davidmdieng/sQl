import streamlit as st
import pandas as pd
import random

# Data Setup
names = ["Rose Gonzalez", "Sean Forbes", "Jack Rogers", "Pat Stumuller", "Andy Young", 
         "Tim Barr", "John Bond", "Stella Pavlova", "Lauren Boyle", "Babara Levy",
         "Josh Davis", "Jane Grey", "Arthur Song", "Ashley James", "Tom Ripley",
         "Liz D'Cruz", "Edna Frank", "Avi Green", "Siddartha Nedaerk", "Jake Llorrac"]
titles = ["SVP, Procurement", "CFO", "VP, Facilities", "SVP, Administration and Finance", "SVP, Operations",
          "SVP, Administration and Finance", "VP, Facilities", "SVP, Production", "SVP, Technology", "SVP, Operations",
          "Director, Warehouse Mgmt", "Dean of Administration", "CEO", "VP, Finance", "Regional General Manager",
          "VP, Production", "VP, Technology", "CFO", "sForce", "sForce"]
companies = ["Edge Communications", "Edge Communications", "Burlington Textiles Corp of America", "Pyramid Construction Inc.", "Dickenson plc",
             "Grand Hotels & Resorts Ltd", "Grand Hotels & Resorts Ltd", "United Oil & Gas Corp.", "United Oil & Gas Corp.", "Express Logistics and Transport",
             "Express Logistics and Transport", "University of Arizona", "United Oil & Gas Corp.", "United Oil & Gas, UK", "United Oil & Gas, Singapore",
             "United Oil & Gas, Singapore", "GenePoint", "United Oil & Gas Corp.", "", ""]

# Random voucher amounts, ensuring 5 companies have $0
voucher_amounts = [random.choice([100, 200, 300, 400, 500]) for _ in range(20)]
zero_indices = random.sample(range(20), 5)  # Get 5 unique indices to assign $0
for index in zero_indices:
    voucher_amounts[index] = 0

data = {
    "Name": names,
    "Title": titles,
    "Company": companies,
    "Voucher Amount": voucher_amounts
}

df = pd.DataFrame(data)

def check_voucher(company_name):
    # Normalize the company name for comparison
    normalized_input = company_name.strip().lower()
    # Attempt to match based on first 3 and last 3 letters, case insensitive
    company_data = df[df['Company'].apply(lambda x: x[:3].lower() == normalized_input[:3] and x[-3:].lower() == normalized_input[-3:] if len(x) >= 3 else False)]
    if not company_data.empty:
        amount = company_data['Voucher Amount'].iloc[0]
        if amount > 0:
            return f"This Company is eligible for a Voucher of ${amount}. Voucher Code: RPA{amount}"
        else:
            return "This Company is not eligible for a Voucher."
    else:
        return "Company not found."

# Streamlit App Layout
st.title('The Voucher Bank')
st.markdown('### Welcome to the Voucher Bank! Enter a company name to check for voucher eligibility.')

company_name = st.text_input('Enter Company Name:', '')

if st.button('Check Eligibility'):
    result = check_voucher(company_name)
    st.success(result)
