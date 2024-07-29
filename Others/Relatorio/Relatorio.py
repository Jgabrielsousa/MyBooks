import pyodbc
import pandas as pd
import streamlit as st
import pandas as pd
import plotly.express as px


st.title = "Graphic Author"
st.set_page_config(layout="wide")

server = 'localhost'
database = 'my-book'
username = 'sa'
password = 'Loginsql2020'
cnxn = pyodbc.connect('DRIVER={SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = cnxn.cursor()

query = "SELECT authorName,	Book,	AmountSalesType,	qdtSubject	,ValueAverage FROM vw_book_avg;"
table = pd.read_sql(query, cnxn)
# print(df.head(26))



authorSelecionado = st.sidebar.selectbox("authorName",table["authorName"].unique(),
                                          index=None,
    placeholder="authorName")

#df_filtered = table[table["Author"] == authorSelecionado]

m = table['authorName'].isin([authorSelecionado])
showFiltered = False if m.any() else True
finalFiltered = table[m | showFiltered]


config = px.pie(table, values="AmountSalesType",names="authorName",title="Grafico Livros")
fields = table[table["authorName"] == authorSelecionado]

config
finalFiltered